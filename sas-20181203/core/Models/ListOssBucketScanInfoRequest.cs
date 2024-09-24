// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketScanInfoRequest : TeaModel {
        /// <summary>
        /// <para>The name of the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iboxpublic****</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the bucket that is used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FuzzBucketName")]
        [Validation(Required=false)]
        public string FuzzBucketName { get; set; }

        /// <summary>
        /// <para>Specifies whether at-risk objects are detected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No at-risk objects are detected.</description></item>
        /// <item><description><b>1</b>: At-risk objects are detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasRisk")]
        [Validation(Required=false)]
        public int? HasRisk { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
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
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The check status of the bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The bucket is not checked.</description></item>
        /// <item><description><b>2</b>: All objects in the bucket are being checked.</description></item>
        /// <item><description><b>3</b>: Only new objects in the bucket are being checked.</description></item>
        /// <item><description><b>4</b>: The bucket is checked.</description></item>
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
