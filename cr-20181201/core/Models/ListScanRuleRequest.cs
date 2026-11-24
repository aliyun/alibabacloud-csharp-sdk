// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanRuleRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-upoulewerx*****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The vulnerability type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>VUL</c>: artifact vulnerability scanning.</description></item>
        /// <item><description><c>SBOM</c>: artifact content analysis.</description></item>
        /// </list>
        /// <para>Default value: <c>VUL</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SBOM</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

    }

}
