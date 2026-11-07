// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateNacosGrayConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want the results to be displayed. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-a</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The configuration content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdf</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The data ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The canary release rule. For a beta release, you can specify one or more client IP addresses for this parameter. You must separate multiple IP addresses with commas (,). For a tag-based canary release, the value is in the format of Tag name=Tag value. You must separate multiple tag values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>key=value1,value2</para>
        /// </summary>
        [NameInMap("GrayRule")]
        [Validation(Required=false)]
        public string GrayRule { get; set; }

        /// <summary>
        /// <para>The canary version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GrayRuleName")]
        [Validation(Required=false)]
        public string GrayRuleName { get; set; }

        /// <summary>
        /// <para>The canary version priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("GrayRulePriority")]
        [Validation(Required=false)]
        public int? GrayRulePriority { get; set; }

        /// <summary>
        /// <para>The canary release type. Beta release (IP address-based canary release) and tag-based canary release are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tags</para>
        /// </summary>
        [NameInMap("GrayType")]
        [Validation(Required=false)]
        public string GrayType { get; set; }

        /// <summary>
        /// <para>The group name. Default value: DEFAULT_GROUP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_GROUP</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-st2212****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The namespace ID. Default value: public.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cf708a5-****-89f2-3ba62c5ee9ba</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values: Create (create a canary release configuration) and Update (update an existing canary release configuration).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create</para>
        /// </summary>
        [NameInMap("OpType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The extended request parameter in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop the canary release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StopGray")]
        [Validation(Required=false)]
        public bool? StopGray { get; set; }

    }

}
