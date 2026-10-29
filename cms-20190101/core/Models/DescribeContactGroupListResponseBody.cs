// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public DescribeContactGroupListResponseBodyContactGroupList ContactGroupList { get; set; }
        public class DescribeContactGroupListResponseBodyContactGroupList : TeaModel {
            [NameInMap("ContactGroup")]
            [Validation(Required=false)]
            public List<DescribeContactGroupListResponseBodyContactGroupListContactGroup> ContactGroup { get; set; }
            public class DescribeContactGroupListResponseBodyContactGroupListContactGroup : TeaModel {
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts Contacts { get; set; }
                public class DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<string> Contact { get; set; }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                [NameInMap("EnableSubscribed")]
                [Validation(Required=false)]
                public bool? EnableSubscribed { get; set; }

                [NameInMap("EnabledWeeklyReport")]
                [Validation(Required=false)]
                public bool? EnabledWeeklyReport { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

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
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>916EE694-03C2-47B6-85EE-5054E3C168D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
