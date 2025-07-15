// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveMessageGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the group administrators.</para>
        /// </summary>
        [NameInMap("AdminList")]
        [Validation(Required=false)]
        public List<string> AdminList { get; set; }

        /// <summary>
        /// <para>The time when the group was created. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698305471</para>
        /// </summary>
        [NameInMap("Createtime")]
        [Validation(Required=false)]
        public long? Createtime { get; set; }

        /// <summary>
        /// <para>The ID of the group creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid1</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The time when the group was deleted. This parameter is returned only if the group was deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698299827</para>
        /// </summary>
        [NameInMap("Deletatime")]
        [Validation(Required=false)]
        public long? Deletatime { get; set; }

        /// <summary>
        /// <para>Indicates whether the group was deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Delete")]
        [Validation(Required=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// <para>The ID of the user who deleted the group. This parameter is returned only if the group was deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid1</para>
        /// </summary>
        [NameInMap("Deletor")]
        [Validation(Required=false)]
        public string Deletor { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest1</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Additional information about the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testgroupinfo</para>
        /// </summary>
        [NameInMap("GroupInfo")]
        [Validation(Required=false)]
        public string GroupInfo { get; set; }

        /// <summary>
        /// <para>The name of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytestgroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The categorized message statistics. This parameter is returned only if the group exists.</para>
        /// </summary>
        [NameInMap("MsgAmount")]
        [Validation(Required=false)]
        public Dictionary<string, long?> MsgAmount { get; set; }

        /// <summary>
        /// <para>The number of online users in the group. This parameter is returned only if the group exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OnlineUserCounts")]
        [Validation(Required=false)]
        public long? OnlineUserCounts { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1815A27D-BAE2-10E6-89FD-D477951C67C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the group is a super group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True</description></item>
        /// <item><description>False</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("SuperLargeGroup")]
        [Validation(Required=false)]
        public bool? SuperLargeGroup { get; set; }

        /// <summary>
        /// <para>The total number of sessions. This parameter is returned only if the group exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalTimes")]
        [Validation(Required=false)]
        public long? TotalTimes { get; set; }

    }

}
