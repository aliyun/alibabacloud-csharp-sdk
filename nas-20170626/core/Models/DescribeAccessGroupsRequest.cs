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
        /// <item><description>The name must be 3 to 64 characters in length.</description></item>
        /// <item><description>The name must start with a letter and can contain letters, digits, underscores (_), and hyphens (-).</description></item>
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
        /// <item><description>standard: General-purpose Apsara File Storage NAS (NAS) file system</description></item>
        /// <item><description>extreme: Extreme NAS file system.</description></item>
        /// <item><description>cpfs: CPFS file system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of permission groups returned per page.</para>
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
        /// <para>Specifies whether to display the creation time of the permission group in UTC.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): The time is displayed in UTC.</description></item>
        /// <item><description>false: The time is not displayed in UTC.</description></item>
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
