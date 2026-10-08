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

        [NameInMap("ServiceGroupsList")]
        [Validation(Required=false)]
        public ListServiceGroupsResponseBodyServiceGroupsList ServiceGroupsList { get; set; }
        public class ListServiceGroupsResponseBodyServiceGroupsList : TeaModel {
            [NameInMap("ListServiceGroups")]
            [Validation(Required=false)]
            public List<ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups> ListServiceGroups { get; set; }
            public class ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

    }

}
