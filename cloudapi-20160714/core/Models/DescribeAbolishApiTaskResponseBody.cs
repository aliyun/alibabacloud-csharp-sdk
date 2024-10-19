// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAbolishApiTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result returned.</para>
        /// </summary>
        [NameInMap("ApiAbolishResults")]
        [Validation(Required=false)]
        public DescribeAbolishApiTaskResponseBodyApiAbolishResults ApiAbolishResults { get; set; }
        public class DescribeAbolishApiTaskResponseBodyApiAbolishResults : TeaModel {
            [NameInMap("ApiAbolishResult")]
            [Validation(Required=false)]
            public List<DescribeAbolishApiTaskResponseBodyApiAbolishResultsApiAbolishResult> ApiAbolishResult { get; set; }
            public class DescribeAbolishApiTaskResponseBodyApiAbolishResultsApiAbolishResult : TeaModel {
                /// <summary>
                /// <para>The unpublishing status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OVER</para>
                /// </summary>
                [NameInMap("AbolishStatus")]
                [Validation(Required=false)]
                public string AbolishStatus { get; set; }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2_page_consent</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4e26cdbbb113416dba1f0285bed29979</para>
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success. Request Success.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>160cb6505e1c43a6b84346856d74eb47</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wb2022021401619286</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The ID of the runtime environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0919f2854a88484c91dc9253347c78f9</para>
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// <para>The name of the runtime environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RELEASE</b></description></item>
                /// <item><description><b>TEST</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8515BA6-81CD-4191-A7CF-C4FCDD3C0D99</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
