// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSophonCommandsResponseBody : TeaModel {
        /// <summary>
        /// <para>The commands.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSophonCommandsResponseBodyData> Data { get; set; }
        public class DescribeSophonCommandsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a action of processing for WAF</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAF Process IP</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The name of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_process_ip_v2</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter configurations.</para>
            /// </summary>
            [NameInMap("ParamConfig")]
            [Validation(Required=false)]
            public List<DescribeSophonCommandsResponseBodyDataParamConfig> ParamConfig { get; set; }
            public class DescribeSophonCommandsResponseBodyDataParamConfig : TeaModel {
                /// <summary>
                /// <para>The regular expression that is used to check the format of the parameter value. If the parameter is left empty, the check is not performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0-9]{4}\.[0-9]{4}\.[0-9]{4}\.[0-9]{4}</para>
                /// </summary>
                [NameInMap("CheckField")]
                [Validation(Required=false)]
                public string CheckField { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b> (default)</description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Necessary")]
                [Validation(Required=false)]
                public bool? Necessary { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.xx.xx.xx</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E1EC464-3BD7-518F-9937-BCC12E6855FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
