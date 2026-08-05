// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLakebaseS3AccountRequest : TeaModel {
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
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query all available regions for your account, including region IDs.</para>
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
        /// <para>The Access Key of the S3 account.</para>
        /// <remarks>
        /// <para>The account name supports only uppercase letters, lowercase letters, and digits, with a maximum length of 32 characters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accname</para>
        /// </summary>
        [NameInMap("UserAccAk")]
        [Validation(Required=false)]
        public string UserAccAk { get; set; }

    }

}
