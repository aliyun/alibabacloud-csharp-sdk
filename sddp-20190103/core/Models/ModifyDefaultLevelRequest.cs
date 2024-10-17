// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyDefaultLevelRequest : TeaModel {
        /// <summary>
        /// <para>The default sensitivity level of data that Data Security Center (DSC) cannot classify as sensitive or insensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A</description></item>
        /// <item><description><b>2</b>: S1</description></item>
        /// <item><description><b>3</b>: S2</description></item>
        /// <item><description><b>4</b>: S3</description></item>
        /// <item><description><b>5</b>: S4</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DefaultId")]
        [Validation(Required=false)]
        public long? DefaultId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sensitivity level ID of data that DSC classifies as sensitive. Separate multiple IDs with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A</description></item>
        /// <item><description><b>2</b>: S1</description></item>
        /// <item><description><b>3</b>: S2</description></item>
        /// <item><description><b>4</b>: S3</description></item>
        /// <item><description><b>5</b>: S4</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4</para>
        /// </summary>
        [NameInMap("SensitiveIds")]
        [Validation(Required=false)]
        public string SensitiveIds { get; set; }

    }

}
