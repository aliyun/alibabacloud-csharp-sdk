// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeOpenApiListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenApiListResponseBodyData Data { get; set; }
        public class DescribeOpenApiListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>200: successful.</description></item>
            /// <item><description>500: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The information about the returned APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;apis&quot;:[{&quot;summary&quot;:&quot;get account information&quot;,&quot;deprecated&quot;:false,&quot;name&quot;:&quot;DescAccountSummary&quot;,&quot;title&quot;:&quot;get account information&quot;}],&quot;childrens&quot;:[],&quot;title&quot;:&quot;account&quot;}]</para>
            /// </summary>
            [NameInMap("Directories")]
            [Validation(Required=false)]
            public object Directories { get; set; }

            /// <summary>
            /// <para>The version number of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-03</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF2ECA2D-D8E6-5021-BF5C-19DD6D52C5B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
