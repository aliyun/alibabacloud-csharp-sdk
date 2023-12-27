// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// 域名配置清单。
        /// </summary>
        [NameInMap("DomainConfigList")]
        [Validation(Required=false)]
        public BatchSetDcdnDomainConfigsResponseBodyDomainConfigList DomainConfigList { get; set; }
        public class BatchSetDcdnDomainConfigsResponseBodyDomainConfigList : TeaModel {
            [NameInMap("DomainConfigModel")]
            [Validation(Required=false)]
            public List<BatchSetDcdnDomainConfigsResponseBodyDomainConfigListDomainConfigModel> DomainConfigModel { get; set; }
            public class BatchSetDcdnDomainConfigsResponseBodyDomainConfigListDomainConfigModel : TeaModel {
                /// <summary>
                /// 配置ID，如果返回为0，则表示该条配置未配置成功，需要重新配置。
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// 域名。
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// 功能名称。
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
