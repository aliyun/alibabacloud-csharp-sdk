// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployApiTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("DeployedResults")]
        [Validation(Required=false)]
        public DescribeDeployApiTaskResponseBodyDeployedResults DeployedResults { get; set; }
        public class DescribeDeployApiTaskResponseBodyDeployedResults : TeaModel {
            [NameInMap("DeployedResult")]
            [Validation(Required=false)]
            public List<DescribeDeployApiTaskResponseBodyDeployedResultsDeployedResult> DeployedResult { get; set; }
            public class DescribeDeployApiTaskResponseBodyDeployedResultsDeployedResult : TeaModel {
                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0433c1cd84724923b7a4f9ca1cfc249c</para>
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// <para>The deployment status of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OVER</para>
                /// </summary>
                [NameInMap("DeployedStatus")]
                [Validation(Required=false)]
                public string DeployedStatus { get; set; }

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
                /// <para>e8da6f6346184da9a30d0dc1888b1f3b</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The runtime environment of the API. Valid values:</para>
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
        /// <para>CA4B3261-F14A-5E33-8608-F75A1DF27AD4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
