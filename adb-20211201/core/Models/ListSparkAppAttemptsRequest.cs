// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSparkAppAttemptsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Spark application.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/455888.html">ListSparkApps</a> operation to query all application IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s202204132018hzprec1ac****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-uf6o6m8p6x***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
