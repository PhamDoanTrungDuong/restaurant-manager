import { Restaurant } from "./restaurant.model";

export interface Status {
    id: number
    name: string
    description: string
    phone: string
    address: string
    created: Date
    updated: Date
    deleted: boolean
    restaurant: Restaurant
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