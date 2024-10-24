// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Format: yyyyMMdd. Example: 20181225.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20201003</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The site from where the message is sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: China site</description></item>
        /// <item><description><b>2</b>: international site</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsGlobe")]
        [Validation(Required=false)]
        public int? IsGlobe { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1 to 50</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Format: yyyyMMdd. Example: 20181225.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20201002</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The type of the message template. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: verification code</description></item>
        /// <item><description><b>1</b>: notification</description></item>
        /// <item><description><b>2</b>: promotional message (Enterprise users only)</description></item>
        /// <item><description><b>3</b>: international purpose (Enterprise users only)</description></item>
        /// <item><description><b>7</b>: digital message</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
