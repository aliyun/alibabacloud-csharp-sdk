// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class UpdateDomainToDomainGroupRequest : TeaModel {
        /// <summary>
        /// <para>The data source for the domain names. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: custom input.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: file upload.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public int? DataSource { get; set; }

        /// <summary>
        /// <para>The ID of the domain name group. Call the <a href="https://help.aliyun.com/document_detail/69362.html">QueryDomainGroupList</a> API to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>An array of domain names. This parameter is required when DataSource is set to 1 (custom input).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// <para>The Base64-encoded content of a file. This parameter is required if you set DataSource to 2. The file must be in <b>.xls</b> or <b>.xlsx</b> format, contain one domain name per line, and not exceed 2 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("FileToUpload")]
        [Validation(Required=false)]
        public string FileToUpload { get; set; }

        /// <summary>
        /// <para>The language of API error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to replace the existing domain names in the group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: Adds the new domain names to the group.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Replaces all existing domain names in the group with the new ones.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Replace")]
        [Validation(Required=false)]
        public bool? Replace { get; set; }

        /// <summary>
        /// <para>The user IP address. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
