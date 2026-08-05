// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageGroupRequest : TeaModel {
        /// <summary>
        /// <para>Interactive Messages application ID.</para>
        /// <remarks>
        /// <para>You must correctly fill in this parameter to perform a normal query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VKL3***</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Page number. Default value: 1. Valid values: 1 to 100000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of message groups to display per page. Default value: 20.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Ascending order by time.</description></item>
        /// <item><description>1: Descending order by time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

        /// <summary>
        /// <para>User ID, which is customized by the user and must be unique within an AppId. Different users must use different UserIds.</para>
        /// <remarks>
        /// <para>You must correctly fill in this parameter to perform a normal query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>de1**a0</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
