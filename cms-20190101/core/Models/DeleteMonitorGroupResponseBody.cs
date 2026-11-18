// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMonitorGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the deletion was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the deleted application group.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public DeleteMonitorGroupResponseBodyGroup Group { get; set; }
        public class DeleteMonitorGroupResponseBodyGroup : TeaModel {
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public DeleteMonitorGroupResponseBodyGroupContactGroups ContactGroups { get; set; }
            public class DeleteMonitorGroupResponseBodyGroupContactGroups : TeaModel {
                [NameInMap("ContactGroup")]
                [Validation(Required=false)]
                public List<DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup> ContactGroup { get; set; }
                public class DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>生产应用分组</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the request fails. The example indicates that the required parameter GroupId is missing. No error message is returned when the deletion is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GroupId is mandatory for this action.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application group was deleted. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
