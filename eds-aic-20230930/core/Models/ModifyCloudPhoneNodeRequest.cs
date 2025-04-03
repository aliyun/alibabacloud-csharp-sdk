// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyCloudPhoneNodeRequest : TeaModel {
        /// <summary>
        /// <para>The name that you want to assign to the cloud phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_name_new</para>
        /// </summary>
        [NameInMap("NewNodeName")]
        [Validation(Required=false)]
        public string NewNodeName { get; set; }

        /// <summary>
        /// <para>The ID of the cloud phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpn-0ugbptfu473fy****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
