using UnityEngine;

public class Wind {

    public float speed {get; set; }

    public float direction {get;set;}

    public float duration { get; set; }

    public Wind(float _speed, float _direction, float _duration)
    {
        this.speed = _speed;
        this.direction = _direction;
        this.duration = _duration;
    }
}
