// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class PageQueryWhiteListSettingRequest : TeaModel {
        /// <summary>
        /// <para>The certificate number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330103xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>The unique identifier of the ID Verification request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha75b4e19a1ddda059b920757b0e12b</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The verification scenario ID. This ID is automatically generated after you create a verification scenario in the console. For more information about how to create a verification scenario, refer to Add a verification scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000xxx</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the ID Verification cloud service. Value: <b>antcloudauth</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DELETE: Deleted.</description></item>
        /// <item><description>VALID: Not deleted and within the validity period (valid).</description></item>
        /// <item><description>INVALID: Not deleted but outside the validity period (invalid).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The end date of the validity period (timestamp in milliseconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725379200000</para>
        /// </summary>
        [NameInMap("ValidEndDate")]
        [Validation(Required=false)]
        public string ValidEndDate { get; set; }

        /// <summary>
        /// <para>The start date of the validity period (timestamp in milliseconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725120000000</para>
        /// </summary>
        [NameInMap("ValidStartDate")]
        [Validation(Required=false)]
        public string ValidStartDate { get; set; }

    }

}
