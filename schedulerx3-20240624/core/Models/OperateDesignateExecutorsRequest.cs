// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class OperateDesignateExecutorsRequest : TeaModel {
        /// <summary>
        /// <para>The address list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public List<string> AddressList { get; set; }

        [NameInMap("AppGroupId")]
        [Validation(Required=false)]
        public long? AppGroupId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the designated machine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: designated worker.</description></item>
        /// <item><description><b>2</b>: designated label.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DesignateType")]
        [Validation(Required=false)]
        public int? DesignateType { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable failover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Transferable")]
        [Validation(Required=false)]
        public bool? Transferable { get; set; }

    }

}
