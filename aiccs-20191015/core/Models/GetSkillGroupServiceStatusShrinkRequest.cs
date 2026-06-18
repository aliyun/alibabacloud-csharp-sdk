// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSkillGroupServiceStatusShrinkRequest : TeaModel {
        /// <summary>
        /// <para>List of agent IDs.</para>
        /// </summary>
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public string AgentIdsShrink { get; set; }

        /// <summary>
        /// <para>The current page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>List of department IDs.</para>
        /// </summary>
        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public string DepIdsShrink { get; set; }

        /// <summary>
        /// <para>End date UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1617761765000</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to query by skill group. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistAgentGrouping")]
        [Validation(Required=false)]
        public bool? ExistAgentGrouping { get; set; }

        /// <summary>
        /// <para>Specifies whether to query by Channel instance group. Default value: <b>false</b>. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.  </description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistChannelInstanceGrouping")]
        [Validation(Required=false)]
        public bool? ExistChannelInstanceGrouping { get; set; }

        /// <summary>
        /// <para>Specifies whether to query by department group. Default value: <b>false</b>. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.  </description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistDepartmentGrouping")]
        [Validation(Required=false)]
        public bool? ExistDepartmentGrouping { get; set; }

        /// <summary>
        /// <para>Specifies whether to query by robot instance group. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistRobotInstanceGrouping")]
        [Validation(Required=false)]
        public bool? ExistRobotInstanceGrouping { get; set; }

        /// <summary>
        /// <para>Specifies whether to query by skill group. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistSkillGroupGrouping")]
        [Validation(Required=false)]
        public bool? ExistSkillGroupGrouping { get; set; }

        /// <summary>
        /// <para>List of skill group IDs.</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIdsShrink { get; set; }

        /// <summary>
        /// <para>AICCS instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page size. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Start date UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615083365000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>Time latitude type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>minute</b>: Minute.  </description></item>
        /// <item><description><b>hour</b>: Hour.  </description></item>
        /// <item><description><b>day</b>: Day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>minute</para>
        /// </summary>
        [NameInMap("TimeLatitudeType")]
        [Validation(Required=false)]
        public string TimeLatitudeType { get; set; }

    }

}
