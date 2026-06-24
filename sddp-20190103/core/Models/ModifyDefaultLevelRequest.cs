// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyDefaultLevelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the default threat level for unidentified data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: N/A.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: S1.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DefaultId")]
        [Validation(Required=false)]
        public long? DefaultId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The IDs of the threat levels for data classified as sensitive. If you specify multiple IDs, separate them with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: N/A.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: S1.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4.</para>
        /// </description></item>
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
