// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreateFixedNoAReportRequest : TeaModel {
        /// <summary>
        /// <para>所属a号码组id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ANoWhiteGroupId")]
        [Validation(Required=false)]
        public long? ANoWhiteGroupId { get; set; }

        /// <summary>
        /// <para>姓名</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>赵**</para>
        /// </summary>
        [NameInMap("CustName")]
        [Validation(Required=false)]
        public string CustName { get; set; }

        /// <summary>
        /// <para>经办人/法人电话</para>
        /// 
        /// <b>Example:</b>
        /// <para>130*****8888</para>
        /// </summary>
        [NameInMap("CustPhoneNo")]
        [Validation(Required=false)]
        public string CustPhoneNo { get; set; }

        /// <summary>
        /// <para>固话客户类型 1:法人,2:经办人</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustType")]
        [Validation(Required=false)]
        public long? CustType { get; set; }

        /// <summary>
        /// <para>证件号码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>370*********</para>
        /// </summary>
        [NameInMap("DocumentNumber")]
        [Validation(Required=false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// <para>证件类型 填写1表示身份证</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DocumentType")]
        [Validation(Required=false)]
        public long? DocumentType { get; set; }

        /// <summary>
        /// <para>固话申请时服务大厅工单号</para>
        /// 
        /// <b>Example:</b>
        /// <para>45***12</para>
        /// </summary>
        [NameInMap("FixedLineWorkId")]
        [Validation(Required=false)]
        public string FixedLineWorkId { get; set; }

        /// <summary>
        /// <para>a号码(固话)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89*****1234</para>
        /// </summary>
        [NameInMap("FixedNoA")]
        [Validation(Required=false)]
        public string FixedNoA { get; set; }

        /// <summary>
        /// <para>正面人像照片 OSS 路径地址</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196033.jpg</para>
        /// </summary>
        [NameInMap("IdCardAlivePhoto")]
        [Validation(Required=false)]
        public string IdCardAlivePhoto { get; set; }

        /// <summary>
        /// <para>身份证反面照片oss路径地址</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196032.jpg</para>
        /// </summary>
        [NameInMap("IdCardBackPhoto")]
        [Validation(Required=false)]
        public string IdCardBackPhoto { get; set; }

        /// <summary>
        /// <para>身份证正面照片oss路径地址</para>
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
        /// <para>备注（客户自己的业务备注，可编辑）</para>
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
