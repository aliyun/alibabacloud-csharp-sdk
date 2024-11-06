// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the domain name.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeDcdnDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeDcdnDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5068995</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// <para>The configurations of the features.</para>
                /// </summary>
                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        /// <summary>
                        /// <para>The name of the configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ttl</para>
                        /// </summary>
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        /// <summary>
                        /// <para>The value of the configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>13</para>
                        /// </summary>
                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The feature name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>set_req_host_header</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The ID of the advanced condition configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The status of the configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b>: successful</description></item>
                /// <item><description><b>testing</b>: testing</description></item>
                /// <item><description><b>failed</b>: The configuration failed.</description></item>
                /// <item><description><b>configuring</b>: The configuration is in progress.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8AA0364-0FDB-4AD5-AC74-D69FAB8924ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
