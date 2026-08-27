// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChatSessionsRequest : TeaModel {
        /// <summary>
        /// <para>Set this parameter to V2 to route requests to the ROS Agent V2 backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The number of sessions to return per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Filters sessions by mode. Valid values: IaCCodeNormal and IaCCodePipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IaCCodePipeline</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The pagination token returned in the previous response. Do not pass this parameter for the first page. Do not reuse an old token after switching Mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAES...</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
