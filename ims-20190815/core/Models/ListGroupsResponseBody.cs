// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListGroupsResponseBody : TeaModel {
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListGroupsResponseBodyGroups Groups { get; set; }
        public class ListGroupsResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListGroupsResponseBodyGroupsGroup> Group { get; set; }
            public class ListGroupsResponseBodyGroupsGroup : TeaModel {
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The <c>marker</c>. This parameter is returned only if the value of <c>IsTruncated</c> is <c>true</c>. If the parameter is returned, you can call this operation again and set this parameter to obtain the truncated part.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>065527AA-2F2E-AD7C-7484-F2626CFE4934</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
