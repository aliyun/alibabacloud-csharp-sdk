// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCenterPolicyListRequest : TeaModel {
        /// <summary>
        /// <para>學術代理功能開關。取值範圍：</para>
        /// <list type="bullet">
        /// <item><description>on：開啟。</description></item>
        /// <item><description>off：關閉。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AcademicProxy")]
        [Validation(Required=false)]
        public string AcademicProxy { get; set; }

        /// <summary>
        /// <para>業務類型。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public int? BusinessType { get; set; }

        /// <summary>
        /// <para>模型庫功能開關。取值範圍：</para>
        /// <list type="bullet">
        /// <item><description>on：開啟。</description></item>
        /// <item><description>off：關閉。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ModelLibrary")]
        [Validation(Required=false)]
        public string ModelLibrary { get; set; }

        /// <summary>
        /// <para>分頁查詢時，當前頁的頁碼。<br>預設值：1。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>分頁查詢時，每頁最大行數。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>雲端電腦策略ID清單。</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public List<string> PolicyGroupId { get; set; }

        /// <summary>
        /// <para>連接埠代理功能開關。取值範圍：</para>
        /// <list type="bullet">
        /// <item><description>on：開啟。</description></item>
        /// <item><description>off：關閉。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PortProxy")]
        [Validation(Required=false)]
        public string PortProxy { get; set; }

        /// <summary>
        /// <para>資源類型。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>雲端電腦策略的生效範圍。</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
