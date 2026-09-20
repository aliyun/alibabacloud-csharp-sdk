// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunTriggerNodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DataWorks workspace to which the trigger node belongs. You can call <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> to query the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>The timestamp of the business date for the trigger node instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1606200230105</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

        /// <summary>
        /// <para>The 13-digit millisecond-level timestamp that specifies the scheduled time of the node task corresponding to the trigger node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1606200230105</para>
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public long? CycleTime { get; set; }

        /// <summary>
        /// <para>The ID of the trigger node. You can call <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> to obtain the node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000011</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

    }

}
