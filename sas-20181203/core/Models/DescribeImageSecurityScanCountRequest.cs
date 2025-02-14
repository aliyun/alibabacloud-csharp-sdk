// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSecurityScanCountRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID for image security scanning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdbbe7aa56cbf4b8f830f83718d26****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Whether it has been processed. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Processed </description></item>
        /// <item><description><b>N</b>: Not processed </description></item>
        /// <item><description><b>A</b>: All</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>SHA256 value of the image digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7978d51f5eddf7612ab15ae46bd4b4257bf59da77c2aafc9d9d8ab41bb3****</para>
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <para>Image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c958b80f-prd_default-9bb0****</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>Image UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>325bfa067ae6c678e59e8a1b34cc****</para>
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// <para>Container image repository ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3df5b5a1f2339eb7ebc7d474b8d4****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>Specifies the container image instance ID.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> API to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cri-p2jahwuuwuk7****</para>
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the container image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

        /// <summary>
        /// <para>Scanning scope.</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// <para>Instance IDs for image security scanning.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
