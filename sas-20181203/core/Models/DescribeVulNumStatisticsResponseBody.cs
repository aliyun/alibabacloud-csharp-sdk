// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulNumStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of application vulnerability entries detected by the scanner on your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppCnt")]
        [Validation(Required=false)]
        public int? AppCnt { get; set; }

        /// <summary>
        /// <para>The number of application vulnerabilities detected by the scanner on your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppNum")]
        [Validation(Required=false)]
        public int? AppNum { get; set; }

        /// <summary>
        /// <para>The total number of handled CMS vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CmsDealedTotalNum")]
        [Validation(Required=false)]
        public int? CmsDealedTotalNum { get; set; }

        /// <summary>
        /// <para>The number of Web-CMS vulnerabilities on your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CmsNum")]
        [Validation(Required=false)]
        public int? CmsNum { get; set; }

        /// <summary>
        /// <para>The number of Linux software vulnerabilities on your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CveNum")]
        [Validation(Required=false)]
        public int? CveNum { get; set; }

        /// <summary>
        /// <para>The number of urgent vulnerabilities on your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EmgNum")]
        [Validation(Required=false)]
        public int? EmgNum { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E22C89D2-FE13-5800-8746-9D0EF1827A59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of middleware vulnerabilities on your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ScaNum")]
        [Validation(Required=false)]
        public int? ScaNum { get; set; }

        /// <summary>
        /// <para>The number of Windows system vulnerabilities on your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SysNum")]
        [Validation(Required=false)]
        public int? SysNum { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities with a high fix priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulAsapSum")]
        [Validation(Required=false)]
        public int? VulAsapSum { get; set; }

        /// <summary>
        /// <para>This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulDealedTotalNum")]
        [Validation(Required=false)]
        public int? VulDealedTotalNum { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities with a medium fix priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulLaterSum")]
        [Validation(Required=false)]
        public int? VulLaterSum { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities with a low fix priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulNntfSum")]
        [Validation(Required=false)]
        public int? VulNntfSum { get; set; }

    }

}
