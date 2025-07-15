// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the domain name.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeLiveDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeLiveDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeLiveDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5003576</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// <para>The attributes of the feature.</para>
                /// </summary>
                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeLiveDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeLiveDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeLiveDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeLiveDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        /// <summary>
                        /// <para>The name of the attribute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>domain_name</para>
                        /// </summary>
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        /// <summary>
                        /// <para>The attribute value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>developer.aliyundoc.com</para>
                        /// </summary>
                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>set_req_host_header</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The configuration status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b></description></item>
                /// <item><description><b>testing</b></description></item>
                /// <item><description><b>failed</b></description></item>
                /// <item><description><b>configuring</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8AA0364-0FDB-4AD5-AC74-D69FAB8924ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
