// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000001</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The name of the custom check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testCheckItemName</para>
        /// </summary>
        [NameInMap("CheckShowName")]
        [Validation(Required=false)]
        public string CheckShowName { get; set; }

        /// <summary>
        /// <para>The source type of the situational awareness check item.</para>
        /// </summary>
        [NameInMap("CheckTypes")]
        [Validation(Required=false)]
        public List<string> CheckTypes { get; set; }

        /// <summary>
        /// <para>Specifies the page number to display when performing a paginated query. The starting value is <b>1</b>, and the default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. The default value is <b>zh</b>. Values:</para>
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

        /// <summary>
        /// <para>Specifies the maximum number of data entries to display per page when performing a paginated query. The default number of data entries displayed per page is 20, and if the PageSize parameter is empty, it will default to returning 20 data entries.</para>
        /// <remarks>
        /// <para>It is recommended that the PageSize value is not left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the check item.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
