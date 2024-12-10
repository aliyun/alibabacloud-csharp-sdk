// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class PageServiceCustomerRequest : TeaModel {
        /// <summary>
        /// <para>Authorization status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

        /// <summary>
        /// <para>Cloud Monitoring - Alert authorization status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CmAuthStatus")]
        [Validation(Required=false)]
        public int? CmAuthStatus { get; set; }

        /// <summary>
        /// <para>The page number of the query result, default is 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>End time. The format is a Unix timestamp, which is the number of milliseconds since January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710641101123</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Cloud Security - Alert authorization status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MonitorAuthStatus")]
        [Validation(Required=false)]
        public int? MonitorAuthStatus { get; set; }

        /// <summary>
        /// <para>Number of records per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Start time. The format is a Unix timestamp, which is the number of milliseconds since January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710641101000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
