// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class PageQueryWhiteListSettingRequest : TeaModel {
        /// <summary>
        /// <para>ID number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330103xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>Unique identifier for real person authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha75b4e19a1ddda059b920757b0e12b</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Current page number, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Number of items per page, default is 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Authentication scene ID. This ID is automatically generated after creating an authentication scene in the console. For how to create an authentication scene, see Adding an Authentication Scene.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000xxx</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>ServiceCode of the real person cloud product, value: <b>antcloudauth</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Status:</para>
        /// <list type="bullet">
        /// <item><description>DELETE: Deleted</description></item>
        /// <item><description>VALID: Not deleted and within the validity period, valid</description></item>
        /// <item><description>INVALID: Not deleted but outside the validity period, invalid</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>End date of validity (timestamp in milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725379200000</para>
        /// </summary>
        [NameInMap("ValidEndDate")]
        [Validation(Required=false)]
        public string ValidEndDate { get; set; }

        /// <summary>
        /// <para>Start date of validity (timestamp in milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725120000000</para>
        /// </summary>
        [NameInMap("ValidStartDate")]
        [Validation(Required=false)]
        public string ValidStartDate { get; set; }

    }

}
