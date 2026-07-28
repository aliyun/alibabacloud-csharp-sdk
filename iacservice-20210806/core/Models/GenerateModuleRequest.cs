// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GenerateModuleRequest : TeaModel {
        /// <summary>
        /// <para>The generation source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Resource: Generates a Terraform HCL template based on resource properties.</description></item>
        /// <item><description>VariableToCode: Generates a final Terraform HCL template by combining variables with an existing Terraform HCL template.</description></item>
        /// <item><description>CodeToVariable: Extracts variable information from a Terraform HCL template.</description></item>
        /// <item><description>Module: Generates Terraform Module code based on variables.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("generateSource")]
        [Validation(Required=false)]
        public string GenerateSource { get; set; }

        /// <summary>
        /// <para>The collection of parameters, passed in key:value format, such as {&quot;vpc_name&quot;:&quot;vpc-test&quot;}.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The syntax. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hcl (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hcl</para>
        /// </summary>
        [NameInMap("syntax")]
        [Validation(Required=false)]
        public string Syntax { get; set; }

        /// <summary>
        /// <para>The existing Terraform HCL template content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terraform {
        /// }</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The Terraform provider version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.260.0</para>
        /// </summary>
        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <para>The Terraform resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud_vpc</para>
        /// </summary>
        [NameInMap("terraformResourceType")]
        [Validation(Required=false)]
        public string TerraformResourceType { get; set; }

    }

}
