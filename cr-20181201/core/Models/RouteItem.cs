// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class RouteItem : TeaModel {
        /// <summary>
        /// <para>Instance Endpoint Type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>Instance Domain</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-instance-registry-vpc.cn-hangzhou.cr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("InstanceDomain")]
        [Validation(Required=false)]
        public string InstanceDomain { get; set; }

        /// <summary>
        /// <para>OSS Domain</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cri-cfafawer***-registry.oss-cn-hangzhou.aliyuncs.com">https://cri-cfafawer***-registry.oss-cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("StorageDomain")]
        [Validation(Required=false)]
        public string StorageDomain { get; set; }

    }

}
