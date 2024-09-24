// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about alert groups that were queried.</para>
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public DescribeContactGroupListResponseBodyContactGroupList ContactGroupList { get; set; }
        public class DescribeContactGroupListResponseBodyContactGroupList : TeaModel {
            [NameInMap("ContactGroup")]
            [Validation(Required=false)]
            public List<DescribeContactGroupListResponseBodyContactGroupListContactGroup> ContactGroup { get; set; }
            public class DescribeContactGroupListResponseBodyContactGroupListContactGroup : TeaModel {
                /// <summary>
                /// <para>The alert contacts in the alert group.</para>
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts Contacts { get; set; }
                public class DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<string> Contact { get; set; }

                }

                /// <summary>
                /// <para>The time when the alert group was created. This value is a UNIX timestamp that represents the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1507070598000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the alert group.</para>
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert group subscribes to weekly reports. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The alert group subscribes to weekly reports.</description></item>
                /// <item><description>false: The alert group does not subscribe to weekly reports.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableSubscribed")]
                [Validation(Required=false)]
                public bool? EnableSubscribed { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert group can subscribe to weekly reports. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The alert group can subscribe to weekly reports.</description></item>
                /// <item><description>false: The alert group cannot subscribe to weekly reports.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The weekly report subscription feature is only available for Alibaba Cloud accounts with more than five Elastic Compute Service (ECS) instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnabledWeeklyReport")]
                [Validation(Required=false)]
                public bool? EnabledWeeklyReport { get; set; }

                /// <summary>
                /// <para>The name of the alert group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Contact1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The time when the alert group was modified. This value is a UNIX timestamp that represents the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1589447759000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The names of alert groups.</para>
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public DescribeContactGroupListResponseBodyContactGroups ContactGroups { get; set; }
        public class DescribeContactGroupListResponseBodyContactGroups : TeaModel {
            [NameInMap("ContactGroup")]
            [Validation(Required=false)]
            public List<string> ContactGroup { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>916EE694-03C2-47B6-85EE-5054E3C168D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of the returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
