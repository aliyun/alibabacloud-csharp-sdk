// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyProjectRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the project. The description can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bastionhost demo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID of the bastion host for which you want to modify project information.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-7mz2v120f0y</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The UIDs of the member accounts to associate with the project after modification.</para>
        /// <remarks>
        /// <para>You can call the ListMembersNotForProject operation to obtain this parameter. If you do not specify this parameter, no changes are made.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>160****5312</para>
        /// </summary>
        [NameInMap("MemberIds")]
        [Validation(Required=false)]
        public string MemberIds { get; set; }

        /// <summary>
        /// <para>The new name of the project. The name must be 1 to 128 characters in length, cannot start with a special character, and can contain only the following special characters: periods (.), underscores (_), hyphens (-), backslashes (\), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>projectname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the project that you want to modify.</para>
        /// <remarks>
        /// <para>You can call the ListProjects operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
