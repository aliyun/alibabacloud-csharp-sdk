// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateLakebaseS3AccountRequest : TeaModel {
        /// <summary>
        /// <para>The PolarFS instance ID.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Access Key of the S3 account.</para>
        /// <remarks>
        /// <para>The account name can contain only uppercase letters, lowercase letters, and digits, and cannot exceed 32 characters in length.</para>
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
        /// <para>A policy document in JSON format that defines the permissions of the S3 account. If this parameter is not specified, the default policy is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;2012-10-17&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:[&quot;s3:<em>&quot;],&quot;Resource&quot;:[&quot;</em>&quot;]}]}</para>
        /// </summary>
        [NameInMap("UserAccPolicy")]
        [Validation(Required=false)]
        public string UserAccPolicy { get; set; }

        /// <summary>
        /// <para>The Secret Key of the S3 account (@sensitive, encryption in transit).</para>
        /// <remarks>
        /// <para>The key must contain uppercase letters, lowercase letters, and digits, and must be greater than 18 and no more than 32 characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password***</para>
        /// </summary>
        [NameInMap("UserAccSk")]
        [Validation(Required=false)]
        public string UserAccSk { get; set; }

    }

}
