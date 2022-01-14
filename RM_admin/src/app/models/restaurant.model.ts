export interface Restaurant {
    id: number
    name: string
    description: string
    phone: string
    address: string
    created: Date
    updated: Date
    deleted: boolean
    createdUser: {
        id: number,
        userName: string
        created: Date
        updated: Date
        createdUserId: number
        updateUserId: number
    },
    updatedUser: {
        id: number,
        userName: string
        created: Date
        updated: Date
        createdUserId: number
        updateUserId: number
    },
}