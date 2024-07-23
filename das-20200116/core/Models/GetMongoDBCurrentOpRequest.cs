// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetMongoDBCurrentOpRequest : TeaModel {
        /// <summary>
        /// <para>The <c>db.currentOp()</c> command that is used to filter sessions. For more information, see <a href="https://docs.mongodb.com/manual/reference/method/db.currentOp/">db.currentOp()</a> of MongoDB Documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;active&quot; : true }</para>
        /// </summary>
        [NameInMap("FilterDoc")]
        [Validation(Required=false)]
        public string FilterDoc { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-uf608087********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> If you do not specify a node ID, the sessions of the primary node are queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23302531</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
