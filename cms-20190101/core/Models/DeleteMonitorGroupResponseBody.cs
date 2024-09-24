// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMonitorGroupResponseBody : TeaModel {
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
        public int? Code { get; set; }

        /// <summary>
        /// <para>The deleted application group.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public DeleteMonitorGroupResponseBodyGroup Group { get; set; }
        public class DeleteMonitorGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>The alert groups that receive alert notifications for the application group.</para>
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public DeleteMonitorGroupResponseBodyGroupContactGroups ContactGroups { get; set; }
            public class DeleteMonitorGroupResponseBodyGroupContactGroups : TeaModel {
                [NameInMap("ContactGroup")]
                [Validation(Required=false)]
                public List<DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup> ContactGroup { get; set; }
                public class DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup : TeaModel {
                    /// <summary>
                    /// <para>The name of the alert group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ECS_Group</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

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
        /// <para>CA35B3AE-4FFD-4A33-AE67-67EF68711EFA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. The value true indicates a success. The value false indicates a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
