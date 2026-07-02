// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Account group list.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<ListGroupsResponseBodyGroups> Groups { get; set; }
        public class ListGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>Group creation time in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Group description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test group</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Group external ID, used for association with external systems. Defaults to the account group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("GroupExternalId")]
            [Validation(Required=false)]
            public string GroupExternalId { get; set; }

            /// <summary>
            /// <para>Group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_name</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Group source ID. If created by importing from other sources, this is the external source ID. Defaults to the instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("GroupSourceId")]
            [Validation(Required=false)]
            public string GroupSourceId { get; set; }

            /// <summary>
            /// <para>Group source type. Currently, only self-built is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>build_in: self-built.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("GroupSourceType")]
            [Validation(Required=false)]
            public string GroupSourceType { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Group last update time in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of matched entries. The maximum number of entries returned in a single request is determined by pageSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
