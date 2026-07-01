// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsTrademarkRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the applicant. The value can be up to 50 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴（中国）有限公司</para>
        /// </summary>
        [NameInMap("TrademarkApplicantName")]
        [Validation(Required=false)]
        public string TrademarkApplicantName { get; set; }

        /// <summary>
        /// <para>The effective and expiration dates of the exclusive right.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2010-12-14~2030-12-13</para>
        /// </summary>
        [NameInMap("TrademarkEffExpDate")]
        [Validation(Required=false)]
        public string TrademarkEffExpDate { get; set; }

        /// <summary>
        /// <para>The trademark name. The value can be up to 15 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

        /// <summary>
        /// <para>The fileKey of the trademark details screenshot.</para>
        /// <ol>
        /// <item><description>How to query a trademark:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Log on to the China Trademark Network, click <b>Trademark Online Query</b>, and take a screenshot of the trademark details.</description></item>
        /// <item><description>Accept the terms of use and enter the <b>Application/Registration Number</b> to query.</description></item>
        /// <item><description>Click the <b>Application/Registration Number</b> to view the details.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>Information about the trademark file uploaded to OSS. File upload requirements:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>The name of the file to be uploaded cannot contain Chinese characters or special characters.</description></item>
        /// <item><description>Only images in JPG, PNG, GIF, and JPEG formats are supported, and the image size cannot exceed 5 MB.</description></item>
        /// <item><description>The screenshot must contain the complete URL.</description></item>
        /// <item><description>The trademark image must be clear and identical to the <b>signature name</b>.</description></item>
        /// <item><description>The <b>applicant name</b> must be identical to the name of the enterprise or institution associated with the signature.</description></item>
        /// <item><description>The trademark status must be registered trademark.</description></item>
        /// </list>
        /// <ol start="3">
        /// <item><description>To obtain the fileKey, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files to OSS</a>.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196031.jpg</para>
        /// </summary>
        [NameInMap("TrademarkPic")]
        [Validation(Required=false)]
        public string TrademarkPic { get; set; }

        /// <summary>
        /// <para>The trademark registration number. The value can be up to 15 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>766905</para>
        /// </summary>
        [NameInMap("TrademarkRegistrationNumber")]
        [Validation(Required=false)]
        public string TrademarkRegistrationNumber { get; set; }

    }

}
