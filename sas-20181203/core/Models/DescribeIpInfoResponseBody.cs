// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIpInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("c2_day_trace")]
        [Validation(Required=false)]
        public string C2DayTrace { get; set; }

        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("day_cnt_30d_tor")]
        [Validation(Required=false)]
        public string DayCnt30dTor { get; set; }

        [NameInMap("day_cnt_30d_web_attack")]
        [Validation(Required=false)]
        public string DayCnt30dWebAttack { get; set; }

        [NameInMap("day_cnt_7d_tor")]
        [Validation(Required=false)]
        public string DayCnt7dTor { get; set; }

        [NameInMap("day_cnt_7d_web_attack")]
        [Validation(Required=false)]
        public string DayCnt7dWebAttack { get; set; }

        [NameInMap("geo")]
        [Validation(Required=false)]
        public string Geo { get; set; }

        [NameInMap("gmt_first_c2")]
        [Validation(Required=false)]
        public string GmtFirstC2 { get; set; }

        [NameInMap("gmt_first_mining_pool")]
        [Validation(Required=false)]
        public string GmtFirstMiningPool { get; set; }

        [NameInMap("gmt_last_c2")]
        [Validation(Required=false)]
        public string GmtLastC2 { get; set; }

        [NameInMap("gmt_last_malicious_login")]
        [Validation(Required=false)]
        public string GmtLastMaliciousLogin { get; set; }

        [NameInMap("gmt_last_malicious_source")]
        [Validation(Required=false)]
        public string GmtLastMaliciousSource { get; set; }

        [NameInMap("gmt_last_mining_pool")]
        [Validation(Required=false)]
        public string GmtLastMiningPool { get; set; }

        [NameInMap("gmt_last_nat")]
        [Validation(Required=false)]
        public string GmtLastNat { get; set; }

        [NameInMap("gmt_last_proxy")]
        [Validation(Required=false)]
        public string GmtLastProxy { get; set; }

        [NameInMap("gmt_last_tor")]
        [Validation(Required=false)]
        public string GmtLastTor { get; set; }

        [NameInMap("gmt_last_web_attack")]
        [Validation(Required=false)]
        public string GmtLastWebAttack { get; set; }

        [NameInMap("idc_name")]
        [Validation(Required=false)]
        public string IdcName { get; set; }

        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("is_c2")]
        [Validation(Required=false)]
        public string IsC2 { get; set; }

        [NameInMap("is_c2_1d")]
        [Validation(Required=false)]
        public string IsC21d { get; set; }

        [NameInMap("is_c2_7d")]
        [Validation(Required=false)]
        public string IsC27d { get; set; }

        [NameInMap("is_idc")]
        [Validation(Required=false)]
        public string IsIdc { get; set; }

        [NameInMap("is_malicious_login")]
        [Validation(Required=false)]
        public string IsMaliciousLogin { get; set; }

        [NameInMap("is_malicious_login_1d")]
        [Validation(Required=false)]
        public string IsMaliciousLogin1d { get; set; }

        [NameInMap("is_malicious_login_7d")]
        [Validation(Required=false)]
        public string IsMaliciousLogin7d { get; set; }

        [NameInMap("is_malicious_source")]
        [Validation(Required=false)]
        public string IsMaliciousSource { get; set; }

        [NameInMap("is_malicious_source_1d")]
        [Validation(Required=false)]
        public string IsMaliciousSource1d { get; set; }

        [NameInMap("is_malicious_source_30d")]
        [Validation(Required=false)]
        public string IsMaliciousSource30d { get; set; }

        [NameInMap("is_malicious_source_7d")]
        [Validation(Required=false)]
        public string IsMaliciousSource7d { get; set; }

        [NameInMap("is_mining_pool")]
        [Validation(Required=false)]
        public string IsMiningPool { get; set; }

        [NameInMap("is_mining_pool_1d")]
        [Validation(Required=false)]
        public string IsMiningPool1d { get; set; }

        [NameInMap("is_mining_pool_7d")]
        [Validation(Required=false)]
        public string IsMiningPool7d { get; set; }

        [NameInMap("is_nat")]
        [Validation(Required=false)]
        public string IsNat { get; set; }

        [NameInMap("is_nat_1d")]
        [Validation(Required=false)]
        public string IsNat1d { get; set; }

        [NameInMap("is_nat_7d")]
        [Validation(Required=false)]
        public string IsNat7d { get; set; }

        [NameInMap("is_proxy")]
        [Validation(Required=false)]
        public string IsProxy { get; set; }

        [NameInMap("is_proxy_1d")]
        [Validation(Required=false)]
        public string IsProxy1d { get; set; }

        [NameInMap("is_proxy_7d")]
        [Validation(Required=false)]
        public string IsProxy7d { get; set; }

        [NameInMap("is_tor")]
        [Validation(Required=false)]
        public string IsTor { get; set; }

        [NameInMap("is_tor_1d")]
        [Validation(Required=false)]
        public string IsTor1d { get; set; }

        [NameInMap("is_tor_7d")]
        [Validation(Required=false)]
        public string IsTor7d { get; set; }

        [NameInMap("is_web_attack")]
        [Validation(Required=false)]
        public string IsWebAttack { get; set; }

        [NameInMap("is_web_attack_1d")]
        [Validation(Required=false)]
        public string IsWebAttack1d { get; set; }

        [NameInMap("is_web_attack_30d")]
        [Validation(Required=false)]
        public string IsWebAttack30d { get; set; }

        [NameInMap("is_web_attack_7d")]
        [Validation(Required=false)]
        public string IsWebAttack7d { get; set; }

        [NameInMap("isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("malicious_login_day_trace")]
        [Validation(Required=false)]
        public string MaliciousLoginDayTrace { get; set; }

        [NameInMap("malicious_score")]
        [Validation(Required=false)]
        public string MaliciousScore { get; set; }

        [NameInMap("malicious_source_day_trace")]
        [Validation(Required=false)]
        public string MaliciousSourceDayTrace { get; set; }

        [NameInMap("mining_pool_day_trace")]
        [Validation(Required=false)]
        public string MiningPoolDayTrace { get; set; }

        [NameInMap("nat_day_trace")]
        [Validation(Required=false)]
        public string NatDayTrace { get; set; }

        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("proxy_day_trace")]
        [Validation(Required=false)]
        public string ProxyDayTrace { get; set; }

        [NameInMap("rdns")]
        [Validation(Required=false)]
        public string Rdns { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("tor_day_trace")]
        [Validation(Required=false)]
        public string TorDayTrace { get; set; }

        [NameInMap("total_day_cnt_tor")]
        [Validation(Required=false)]
        public string TotalDayCntTor { get; set; }

        [NameInMap("total_day_cnt_web_attack")]
        [Validation(Required=false)]
        public string TotalDayCntWebAttack { get; set; }

        [NameInMap("web_attack_day_trace")]
        [Validation(Required=false)]
        public string WebAttackDayTrace { get; set; }

    }

}
