// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePhoneNoAReportRequest : TeaModel {
        /// <summary>
        /// <para>ID of the A-number group. On the <a href="https://dyplsnext.console.aliyun.com/qualification">Qualification Management</a> page, click View Details in the A-number whitelist section of the relevant qualification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("ANoWhiteGroupId")]
        [Validation(Required=false)]
        public long? ANoWhiteGroupId { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>赵**</para>
        /// </summary>
        [NameInMap("CustName")]
        [Validation(Required=false)]
        public string CustName { get; set; }

        /// <summary>
        /// <para>Certificate number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>370*********</para>
        /// </summary>
        [NameInMap("DocumentNumber")]
        [Validation(Required=false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// <para>Certificate type. Enter 1 for an ID card.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DocumentType")]
        [Validation(Required=false)]
        public long? DocumentType { get; set; }

        /// <summary>
        /// <para>OSS path of the front-facing portrait photo.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196033.jpg</para>
        /// </summary>
        [NameInMap("IdCardAlivePhoto")]
        [Validation(Required=false)]
        public string IdCardAlivePhoto { get; set; }

        /// <summary>
        /// <para>OSS path of the photo of the back side (portrait side) of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196032.jpg</para>
        /// </summary>
        [NameInMap("IdCardBackPhoto")]
        [Validation(Required=false)]
        public string IdCardBackPhoto { get; set; }

        /// <summary>
        /// <para>OSS path of the photo of the front side (national emblem side) of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196031.jpg</para>
        /// </summary>
        [NameInMap("IdCardFrontPhoto")]
        [Validation(Required=false)]
        public string IdCardFrontPhoto { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130*****1234</para>
        /// </summary>
        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        /// <summary>
        /// <para>Remark (business remark added by the user).</para>
        /// 
        /// <b>Example:</b>
        /// <para>***报备</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
