// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GenerateModuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The generated Terraform HCL template code content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terraform {
        ///   required_providers {
        ///     alicloud = {
        ///       source   = &quot;aliyun/alicloud&quot;
        ///       version  = &quot;1.260.0&quot;
        ///     }
        ///   }
        /// }</para>
        /// <para>resource &quot;alicloud_vpc&quot; &quot;default&quot; {
        ///  vpc_name = &quot;vpc-test&quot;
        /// }</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>The variables and resource properties in the generated template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;vpc_name&quot;:&quot;vpc-test&quot;}</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B40D088-E929-504B-8802-C1759A993FA2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
