// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetMySQLAllSessionAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para> Only ApsaraDB RDS for MySQL, PolarDB for MySQL, and PolarDB-X 2.0 instances are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> You must specify this parameter for PolarDB for MySQL clusters. If you do not specify a node ID, the session data of the primary node is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-wz954ryd8f893****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The asynchronous request ID.</para>
        /// <remarks>
        /// <para> GetMySQLAllSessionAsync is an asynchronous operation. After a request is sent, the system does not return complete results but returns a <b>request ID</b>. You need to use the <b>request ID</b> to initiate requests until the value of the <b>isFinish</b> field in the returned results is <b>true</b>, the complete results are returned. This indicates that to obtain complete data, you must call this operation at least twice.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>async__507044db6c4eadfa2dab9b084e80****</para>
        /// </summary>
        [NameInMap("ResultId")]
        [Validation(Required=false)]
        public string ResultId { get; set; }

    }

}
