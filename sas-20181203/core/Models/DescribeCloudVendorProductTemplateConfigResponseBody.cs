// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudVendorProductTemplateConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Template configuration. This parameter is a JSON structure that includes the following fields: - <b>vendors</b>: A collection of vendor template configuration information. - <b>vendorType</b>: Vendor code, <b>CHAITIN</b> takes the value <b>100</b>, <b>FORTINET</b> takes the value <b>101</b>, and <b>THREATBOOK</b> takes the value <b>102</b>. - <b>vendor</b>: Vendor. Takes the values <b>CHAITIN</b>, <b>FORTINET</b>, or <b>THREATBOOK</b>. - <b>displayName</b>: Display name. Takes the values <b>Chaitin</b>, <b>Fortinet</b>, or <b>Threatbook</b>. - <b>products</b>: A list of template configuration information. This parameter is a JSON structure that includes the following fields: - <b>product</b>: Product code. When <b>vendor</b> is <b>CHAITIN</b>, it takes the value <b>webFirewall</b>; when <b>vendor</b> is <b>FORTINET</b>, it takes the value <b>fortigate</b>; when <b>vendor</b> is <b>THREATBOOK</b>, it takes the value <b>threatIntelligence</b>. - <b>displayName</b>: Product display name. When <b>vendor</b> is <b>CHAITIN</b>, it takes the value <b>WAF</b>; when <b>vendor</b> is <b>FORTINET</b>, it takes the value <b>FortiGate Firewall</b>; when <b>vendor</b> is <b>THREATBOOK</b>, it takes the value <b>Threat Intelligence API</b>. - <b>description</b>: Link to the technical support document for the product. - <b>backendConfig</b>: A list of API field mapping rules. This parameter is a JSON structure that includes the following fields: - <b>apiParams</b>: API field mapping rules. This parameter is a Map structure where the key is the backend field mapping key. The value is a JSON structure that includes the following fields: - <b>field</b>: Property key. - <b>format</b>: Type of the property value, which can be <b>text</b> or <b>json</b>. - <b>fields</b>: Fields that need to be filled in the template. This parameter is a JSON structure that includes the following fields: - <b>displayName</b>: Field display name. - <b>editable</b>: Whether the field is editable. Takes the values <b>true</b> or <b>false</b>. <b>true</b> means editable, <b>false</b> means not editable. - <b>fieldType</b>: Type of the field value. Takes the values <b>text</b> or <b>password</b>. - <b>required</b>: Whether the field is required. Takes the values <b>true</b> or <b>false</b>. <b>true</b> means required, <b>false</b> means not required. - <b>fieldId</b>: Field key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;vendors\&quot;:[{\&quot;vendorType\&quot;:100,\&quot;vendor\&quot;:\&quot;CHAITIN\&quot;,\&quot;displayName\&quot;:\&quot;Chaitin\&quot;,\&quot;products\&quot;:[{\&quot;product\&quot;:\&quot;webFirewall\&quot;,\&quot;displayName\&quot;:\&quot;WAF\&quot;,\&quot;backendConfig\&quot;:{\&quot;apiParams\&quot;:{\&quot;SecretKey\&quot;:{\&quot;field\&quot;:\&quot;apiToken\&quot;,\&quot;format\&quot;:\&quot;text\&quot;},\&quot;SecretId\&quot;:{\&quot;field\&quot;:\&quot;endpoint\&quot;,\&quot;format\&quot;:\&quot;text\&quot;},\&quot;Vendor\&quot;:{\&quot;field\&quot;:\&quot;vendor\&quot;,\&quot;format\&quot;:\&quot;text\&quot;},\&quot;CtdrCloudUserId\&quot;:{\&quot;field\&quot;:\&quot;ctdrCloudUserId\&quot;,\&quot;format\&quot;:\&quot;text\&quot;},\&quot;ExtendInfo\&quot;:{\&quot;format\&quot;:\&quot;json\&quot;,\&quot;fields\&quot;:[\&quot;product\&quot;,\&quot;remark\&quot;]}}},\&quot;description\&quot;:\&quot;<a href="https://docs.waf-ce.chaitin.cn/%E6%9B%B4%E5%A4%9A%E6%8A%80%E6%9C%AF%E6%96%87%E6%A1%A3/OPENAPI%5C%5C%22,%5C%5C%22fields%5C%5C%22:%5B%7B%5C%5C%22displayName%5C%5C%22:%5C%5C%22Endpoint%5C%5C%22,%5C%5C%22fieldType%5C%5C%22:%5C%5C%22text%5C%5C%22,%5C%5C%22prompt%5C%5C%22:%5C%5C%22Enter">https://docs.waf-ce.chaitin.cn/%E6%9B%B4%E5%A4%9A%E6%8A%80%E6%9C%AF%E6%96%87%E6%A1%A3/OPENAPI\\&quot;,\\&quot;fields\\&quot;:[{\\&quot;displayName\\&quot;:\\&quot;Endpoint\\&quot;,\\&quot;fieldType\\&quot;:\\&quot;text\\&quot;,\\&quot;prompt\\&quot;:\\&quot;Enter</a> an endpoint that is in the IP address:Port number format.\&quot;,\&quot;required\&quot;:true,\&quot;fieldId\&quot;:\&quot;endpoint\&quot;},{\&quot;displayName\&quot;:\&quot;API Token\&quot;,\&quot;fieldType\&quot;:\&quot;password\&quot;,\&quot;required\&quot;:true,\&quot;fieldId\&quot;:\&quot;apiToken\&quot;},{\&quot;displayName\&quot;:\&quot;‌Device Name‌ (The cloud_user_id field in the device connection logs will uniquely identify the device)\&quot;,\&quot;fieldType\&quot;:\&quot;text\&quot;,\&quot;required\&quot;:true,\&quot;fieldId\&quot;:\&quot;ctdrCloudUserId\&quot;},{\&quot;displayName\&quot;:\&quot;Remark\&quot;,\&quot;fieldType\&quot;:\&quot;text\&quot;,\&quot;required\&quot;:false,\&quot;fieldId\&quot;:\&quot;remark\&quot;}]}]}]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for this request, and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD380235-A0B8-540D-A0D5-D6288446****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
