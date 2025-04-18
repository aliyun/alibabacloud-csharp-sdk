// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDocParsingResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDocParsingResultResponseBodyData Data { get; set; }
        public class GetDocParsingResultResponseBodyData : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description>The parsed content of the document.</description></item>
            /// <item><description>The format (markdown or json) is determined by the returnFormat parameter. For specific format details, refer to: <a href="https://www.alibabacloud.com/help/en/energy-expert/developer-reference/interface-attached-information#b644b6255cojj">json return structure</a></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;doc_info\&quot;:{\&quot;languages\&quot;:[\&quot;zh\&quot;,\&quot;en\&quot;],\&quot;doc_type\&quot;:\&quot;pdf\&quot;,\&quot;pdf_toc\&quot;:[{\&quot;title\&quot;:\&quot;封面\&quot;,\&quot;level\&quot;:0,\&quot;page\&quot;:0}],\&quot;pages\&quot;:366,\&quot;page_list\&quot;:[{\&quot;imageWidth\&quot;:596,\&quot;imageHeight\&quot;:842,\&quot;pageIdAllDocs\&quot;:0,\&quot;fileIndex\&quot;:0,\&quot;pageIdCurDoc\&quot;:0,\&quot;angle\&quot;:0}],\&quot;doc_data\&quot;:[{\&quot;uniqueId\&quot;:\&quot;about_us_para\&quot;,\&quot;page_num\&quot;:\&quot;01\&quot;,\&quot;index\&quot;:\&quot;xxx\&quot;,\&quot;name\&quot;:\&quot;xxx\&quot;,\&quot;type\&quot;:\&quot;xxxx\&quot;,\&quot;subType\&quot;:\&quot;xxx\&quot;,\&quot;text\&quot;:\&quot;xxx\&quot;,\&quot;before_text\&quot;:\&quot;xxx\&quot;,\&quot;after_text\&quot;:\&quot;xxx\&quot;,\&quot;extInfo\&quot;:[{\&quot;uniqueId\&quot;:\&quot;b0x1x0\&quot;,\&quot;pos\&quot;:[{\&quot;x\&quot;:229,\&quot;y\&quot;:208},{\&quot;x\&quot;:421,\&quot;y\&quot;:208},{\&quot;x\&quot;:421,\&quot;y\&quot;:242},{\&quot;x\&quot;:229,\&quot;y\&quot;:242}],\&quot;text\&quot;:\&quot;Kurt Götze\&quot;,\&quot;type\&quot;:\&quot;Text\&quot;,\&quot;subType\&quot;:\&quot;Text\&quot;,\&quot;pageNum\&quot;:[0],\&quot;index\&quot;:0}]}]}}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
