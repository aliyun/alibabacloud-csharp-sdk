// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineDetailRequest : TeaModel {
        /// <summary>
        /// <para>The key of the baseline sub-item.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageBaselineItemList~~">DescribeImageBaselineItemList</a> operation to obtain this parameter from the BaselineItemInfos[].BaselineItemKey field in the response.
        /// This parameter is required. If it is not provided, the API returns HTTP 400 and the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Values include but are not limited to: ak_leak, duplicate_uid, duplicate_pwd_hash, and non_pwd_user</para>
        /// </summary>
        [NameInMap("BaselineItemKey")]
        [Validation(Required=false)]
        public string BaselineItemKey { get; set; }

        /// <summary>
        /// <para>The UUID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06293273b67d19516cfcc712194f****</para>
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
