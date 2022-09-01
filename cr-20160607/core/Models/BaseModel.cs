using Tea;

namespace AlibabaCloud.SDK.Cr20160607.Models
{
    public abstract class BaseModel : TeaModel
    {
        [NameInMap("body")]
        [Validation(Required = true)]
        public virtual string Body { get; set; }
    }
}
