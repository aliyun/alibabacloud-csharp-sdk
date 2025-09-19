// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSecurityScanCountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster that you want to scan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdbbe7aa56cbf4b8f830f83718d26****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The handling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: handled.</description></item>
        /// <item><description><b>N</b>: unhandled.</description></item>
        /// <item><description><b>A</b>: all.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The SHA-256 value of the image digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7978d51f5eddf7612ab15ae46bd4b4257bf59da77c2aafc9d9d8ab41bb3****</para>
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <para>The tag of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c958b80f-prd_default-9bb0****</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>The UUID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>325bfa067ae6c678e59e8a1b34cc****</para>
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3df5b5a1f2339eb7ebc7d474b8d4****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cri-p2jahwuuwuk7****</para>
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the Container Registry repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

        /// <summary>
        /// <para>The assets that you want to scan.</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// <para>The IDs of the instances that you want to scan.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
