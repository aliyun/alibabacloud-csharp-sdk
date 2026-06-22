// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketScanInfoRequest : TeaModel {
        /// <summary>
        /// <para>The bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iboxpublic****</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The bucket name for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FuzzBucketName")]
        [Validation(Required=false)]
        public string FuzzBucketName { get; set; }

        /// <summary>
        /// <para>Specifies whether risky files are detected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risks detected.</description></item>
        /// <item><description><b>1</b>: Risky files exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasRisk")]
        [Validation(Required=false)]
        public int? HasRisk { get; set; }

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
        /// <para>The maximum number of entries to return on each page in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The detection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Not scanned.</description></item>
        /// <item><description><b>2</b>: Full scan in progress.</description></item>
        /// <item><description><b>3</b>: Incremental scan in progress.</description></item>
        /// <item><description><b>4</b>: Scanned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
