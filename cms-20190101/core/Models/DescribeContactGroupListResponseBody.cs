// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. Note that 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of alarm contact groups.</para>
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
                /// <para>List of contacts.</para>
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
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-07T03:52:30Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Description information of the alarm contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Devops-运维组</para>
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// <para>Indicates whether the weekly report subscription function is enabled. Values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Yes.</para>
                /// </description></item>
                /// <item><description><para>false: No.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableSubscribed")]
                [Validation(Required=false)]
                public bool? EnableSubscribed { get; set; }

                /// <summary>
                /// <para>Indicates whether the weekly report function is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnabledWeeklyReport")]
                [Validation(Required=false)]
                public bool? EnabledWeeklyReport { get; set; }

                /// <summary>
                /// <para>Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-04T02:12:06Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>List of alarm contact groups.</para>
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
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>916EE694-03C2-47B6-85EE-5054E3C168D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Success.</para>
        /// </description></item>
        /// <item><description><para>false: Failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
