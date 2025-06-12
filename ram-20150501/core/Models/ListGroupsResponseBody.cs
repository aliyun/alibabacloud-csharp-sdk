// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the RAM user groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListGroupsResponseBodyGroups Groups { get; set; }
        public class ListGroupsResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListGroupsResponseBodyGroupsGroup> Group { get; set; }
            public class ListGroupsResponseBodyGroupsGroup : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dev-Team</para>
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The ID of the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-FpMEHiMysofp****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dev-Team</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> This parameter is returned only when <c>IsTruncated</c> is <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>065527AA-2F2E-AD7C-7484-F2626CFE4934</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
