// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListServiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5281053-08e4-47a5-b2ab-5c0323de7b5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about service groups.</para>
        /// </summary>
        [NameInMap("ServiceGroupsList")]
        [Validation(Required=false)]
        public ListServiceGroupsResponseBodyServiceGroupsList ServiceGroupsList { get; set; }
        public class ListServiceGroupsResponseBodyServiceGroupsList : TeaModel {
            [NameInMap("ListServiceGroups")]
            [Validation(Required=false)]
            public List<ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups> ListServiceGroups { get; set; }
            public class ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups : TeaModel {
                /// <summary>
                /// <para>The time when the service group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1575357165770</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the service group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>789d9cda-74b1-<b><b>-</b></b>-05e21a0a7661</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the service group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas-test-group</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

    }

}
