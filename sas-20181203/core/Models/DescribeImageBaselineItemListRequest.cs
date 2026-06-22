// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineItemListRequest : TeaModel {
        /// <summary>
        /// <para>The key of the baseline category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ak_leak</para>
        /// </summary>
        [NameInMap("BaselineClassKey")]
        [Validation(Required=false)]
        public string BaselineClassKey { get; set; }

        /// <summary>
        /// <para>The key of the baseline name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Access Key泄露</para>
        /// </summary>
        [NameInMap("BaselineNameKey")]
        [Validation(Required=false)]
        public string BaselineNameKey { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The UUID of the image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b5c7193300da2070220038718ad****</para>
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scan scope collection.</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// <para>The fix status of the baseline risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: unfixed</description></item>
        /// <item><description><b>1</b>: fixed</description></item>
        /// <item><description><b>2</b>: pending verification</description></item>
        /// <item><description><b>3</b>: fix failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of image UUIDs.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
