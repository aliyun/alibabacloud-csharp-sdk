// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 3 to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name must start with a letter and can contain letters, digits, underscores (_), or hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_VPC_GROUP_NAME</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard (default): General-purpose NAS.</description></item>
        /// <item><description>extreme: Extreme NAS.</description></item>
        /// <item><description>cpfs: Cloud Parallel File Storage (CPFS).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// <para>Start value (default value): 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of permission groups on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the returned time is displayed in UTC.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): The returned time is displayed in UTC.</description></item>
        /// <item><description>false: The returned time is not displayed in UTC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseUTCDateTime")]
        [Validation(Required=false)]
        public bool? UseUTCDateTime { get; set; }

    }

}
