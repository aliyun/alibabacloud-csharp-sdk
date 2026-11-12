// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CheckPolarClawSkillRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the OSS bucket that stores the skill files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BucketRegionId")]
        [Validation(Required=false)]
        public string BucketRegionId { get; set; }

        /// <summary>
        /// <para>The type of the bucket used for skill files. UserOwned indicates a user-owned bucket. Hosted indicates a hosted bucket, which requires corresponding permissions. Usage notes: The parameter dependencies for each value specify that OSSBucket is required for UserOwned, and whitelist permissions are required for Hosted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserOwned</para>
        /// </summary>
        [NameInMap("BucketType")]
        [Validation(Required=false)]
        public string BucketType { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket to be disassociated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-bucket-test</para>
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The skill name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarclawhub</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The skill version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0</para>
        /// </summary>
        [NameInMap("SkillVersion")]
        [Validation(Required=false)]
        public string SkillVersion { get; set; }

        /// <summary>
        /// <para>The brief description of the skill. This parameter is actually required. If it is not provided, the service returns InvalidParam (404).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample for managing PolarDB skills</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The tag details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;PolarDB\&quot;,\&quot;programming\&quot;]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title. This parameter is actually required. If it is not provided, the service returns InvalidParam (404).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarClawHub</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
