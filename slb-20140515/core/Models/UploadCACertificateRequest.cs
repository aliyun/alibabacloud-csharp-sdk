// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadCACertificateRequest : TeaModel {
        /// <summary>
        /// <para>The information about the CA certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CACertificate")]
        [Validation(Required=false)]
        public string CACertificate { get; set; }

        /// <summary>
        /// <para>The CA certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mycacert01</para>
        /// </summary>
        [NameInMap("CACertificateName")]
        [Validation(Required=false)]
        public string CACertificateName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region of the CA certificates.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401682.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rto*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UploadCACertificate</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UploadCACertificateRequestTag> Tag { get; set; }
        public class UploadCACertificateRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: <b>1</b> to <b>20</b>. The tag key cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: <b>1 to 20</b>. The tag value can be an empty string. The tag value must be 1 to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
