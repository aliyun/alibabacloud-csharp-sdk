// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain configurations.</para>
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
                /// <para>The ID of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The name of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>set_resp_header</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
