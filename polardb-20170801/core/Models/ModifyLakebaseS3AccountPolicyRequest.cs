// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyLakebaseS3AccountPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The PolarFS instance ID. You can call the DescribePolarFs operation to query available instances and their IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("PfsInstanceId")]
        [Validation(Required=false)]
        public string PfsInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to view the regions of all clusters under the target account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The access key of the S3 account whose policy you want to modify.</para>
        /// <remarks>
        /// <para>You cannot modify the default account.</para>
        /// </remarks>
        /// <remarks>
        /// <para>You can call the ListLakebaseS3Accounts operation to obtain the account access key. Select an account with AccountType set to user.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accname</para>
        /// </summary>
        [NameInMap("UserAccAk")]
        [Validation(Required=false)]
        public string UserAccAk { get; set; }

        /// <summary>
        /// <para>The user account policy in JSON object format. The Version and Statement fields are required. Statement.Action must specify explicit actions such as s3:GetObject and s3:PutObject. The s3:* wildcard is not supported. Statement.Resource must specify explicit ARNs such as arn:aws:s3:::bucket-name/<em>. A standalone asterisk (</em>) is not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;2012-10-17&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:[&quot;s3:GetObject&quot;,&quot;s3:PutObject&quot;],&quot;Resource&quot;:[&quot;arn:aws:s3:::my-bucket/*&quot;]}]}</para>
        /// </summary>
        [NameInMap("UserAccPolicy")]
        [Validation(Required=false)]
        public string UserAccPolicy { get; set; }

    }

}
